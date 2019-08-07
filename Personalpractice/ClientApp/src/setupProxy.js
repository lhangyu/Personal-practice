﻿
const proxy = require('http-proxy-middleware');

module.exports = (app) => {
    app.use(proxy('/api', {
        target: 'http://localhost:6916/',
        changeOrigin: true,
        logLevel: "debug"
    }));
};
