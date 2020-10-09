/// <binding AfterBuild='build' />

var gulp = require("gulp");
var sass = require("gulp-sass");
var del = require("del");

var paths = {
    src: {
        css: './Content/sass/**/*.scss'
    },
    dest: {
        css: './wwwroot/css'
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

exports.build = gulp.series(clean, compileSass);