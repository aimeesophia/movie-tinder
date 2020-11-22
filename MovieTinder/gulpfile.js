/// <binding AfterBuild='build' />

var gulp = require("gulp");
var sass = require("gulp-sass");
var del = require("del");

var paths = {
    src: {
        css: './Content/sass/**/*.scss',
        jquery: './Content/scripts/lib/jquery/jquery.js'
    },
    dest: {
        css: './wwwroot/css',
        jquery: './wwwroot/js/lib/jquery'
    }
}

function clean() {
    return del(paths.dest.css, {
        force: true
    });
}

function compileSass() {
    return gulp.src(paths.src.css)
        .pipe(sass({ outputStyle: 'compressed' }).on('error', sass.logError))
        .pipe(gulp.dest(paths.dest.css));
}

function copyJquery() {
    return gulp.src(paths.src.jquery)
        .pipe(gulp.dest(paths.dest.jquery));
}

exports.build = gulp.series(clean, compileSass, copyJquery);