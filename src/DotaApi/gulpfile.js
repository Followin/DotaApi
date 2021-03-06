﻿/// <binding BeforeBuild='clean, min' />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp'),
    rimraf = require('rimraf'),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    uglify = require('gulp-uglify');

var paths = {
    webroot: "./wwwroot/"
};

paths.js = paths.webroot + "assets/js/**/*.js";
paths.jslib = paths.webroot + "lib/**/*.js";
paths.css = paths.webroot + "css/**/*.css";
paths.csslib = paths.webroot + "lib/**/*.css";
paths.concatJsDest = paths.webroot + "js/site.min.js";
paths.concatJsLib = paths.webroot + "js/vendor.min.js";
paths.concatCssDest = paths.webroot + "css/site.min.css";

gulp.task('clean:js', function (cb) {
    rimraf(paths.concatJsDest, cb);
});

gulp.task('clean:css', function(cb) {
    rimraf(paths.concatCssDest, cb);
});

gulp.task('clean', ["clean:js", "clean:css"]);

gulp.task("min:js", function() {
    return gulp.src([paths.js], { base: "." })
        .pipe(concat(paths.concatJsDest))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task("min:css", function () {
    return gulp.src([paths.css, paths.csslib], { base: "." })
        .pipe(concat(paths.concatCssDest))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});

gulp.task("min", ["min:js", "min:css"]);