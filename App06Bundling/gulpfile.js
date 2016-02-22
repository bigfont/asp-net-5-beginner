/// <binding Clean='clean' />
"use strict";

var gulp = require("gulp"),
  rimraf = require("rimraf"),
  concat = require("gulp-concat"),
  cssmin = require("gulp-cssmin"),
  uglify = require("gulp-uglify"),
  copy = require("gulp-copy");

var webroot = "./wwwroot/";

var paths = {
  js: [
    webroot + "lib/jquery/dist/jquery.min.js",
    webroot + "lib/bootstrap/dist/js/bootstrap.js",
    webroot + "js/**/*.js"
  ],
  minJs: webroot + "js/**/*.min.js",
  css: [
    webroot + "lib/bootstrap/dist/css/bootstrap.css",
    webroot + "css/**/*.css"
  ],
  minCss: webroot + "css/**/*.min.css",
  concatJsDest: webroot + "bundles/js/site-bundle.min.js",
  concatCssDest: webroot + "bundles/css/site-bundle.min.css",
  fonts: [webroot + "lib/bootstrap/dist/fonts/*"],
  fontsDestFolder: webroot + "bundles/fonts/"
};

gulp.task("clean", function (cb) {
  rimraf(webroot + "bundles", cb);
});

gulp.task("min:js", function () {
  return gulp.src(paths.js.concat(["!" + paths.minJs]), {
    base: "."
  })
    .pipe(concat(paths.concatJsDest))
    .pipe(uglify())
    .pipe(gulp.dest("."));
});

gulp.task("min:css", function () {
  return gulp.src(paths.css.concat(["!" + paths.minCss]))
    .pipe(concat(paths.concatCssDest))
    .pipe(cssmin())
    .pipe(gulp.dest("."));
});

gulp.task("min:fonts", function () {
  return gulp.src(paths.fonts)
    .pipe(copy(paths.fontsDestFolder, { prefix: 5 }));
})

gulp.task("min", ["min:js", "min:css", "min:fonts"]);
