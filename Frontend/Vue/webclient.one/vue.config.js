// Please reference following link for detailed info:
// https://cli.vuejs.org/config/

module.exports = {
    // The base URL your application bundle will be deployed at.
    // By default, Vue CLI assumes your app will be deployed at the root of a domain, e.g. https://www.my-app.com/.
    // If your app is deployed at a sub-path, you will need to specify that sub-path using this option.
    // For example, if your app is deployed at https://www.foobar.com/my-app/, set baseUrl to '/my-app/'.
    baseUrl: '/',

    // The directory where the production build files will be generated in when running vue-cli-service build.
    // Note the target directory will be removed before building (this behavior can be disabled by passing --no-clean when building).
    outputDir: 'build_output',

    // A directory (relative to outputDir) to nest generated static assets (js, css, img, fonts) under.
    assetsDir: '',

    // Specify the output path for the generated index.html (relative to outputDir). Can also be an absolute path.
    indexPath: 'index.html',

    // By default, generated static assets contains hashes in their filenames for better caching control.
    // However, this requires the index HTML to be auto-generated by Vue CLI.
    // If you cannot make use of the index HTML generated by Vue CLI, you can disable filename hashing by setting this option to false.
    filenameHashing: true,

    // Build the app in multi-page mode. Each "page" should have a corresponding JavaScript entry file.
    // The value should be an object where the key is the name of the entry, and the value is either:
    // An object that specifies its entry, template, filename, title and chunks (all optional except entry). Any other properties added beside those will also be passed directly to html-webpack-plugin, allowing user to customize said plugin;
    // Or a string specifying its entry.
    pages: undefined,

    // Whether to perform lint-on-save during development using eslint-loader. This value is respected only when @vue/cli-plugin-eslint is installed.
    lintOnSave: true,

    // Whether to use the build of Vue core that includes the runtime compiler.
    // Setting it to true will allow you to use the template option in Vue components, but will incur around an extra 10kb payload for your app.
    runtimeCompiler: false,

    // By default babel-loader ignores all files inside node_modules. If you want to explicitly transpile a dependency with Babel, you can list it in this option.
    transpileDependencies: [],

    // Setting this to false can speed up production builds if you don't need source maps for production.
    productionSourceMap: true,

    // Configure the crossorigin attribute on <link rel="stylesheet"> and <script> tags in generated HTML.
    // Note that this only affects tags injected by html-webpack-plugin - tags directly added in the source template (public/index.html) are not affected.
    crossorigin: undefined,

    // Set to true to enable Subresource Integrity (SRI) on <link rel="stylesheet"> and <script> tags in generated HTML.
    // If you are hosting your built files on a CDN, it is a good idea to enable this for additional security.
    integrity: false,

    // configureWebpack: Object | Function

    // A function that will receive an instance of ChainableConfig powered by webpack-chain. Allows for more fine-grained modification of the internal webpack config.
    // chainWebpack: config => {
    //     config.module
    //         .rule("istanbul")
    //         .test(/\.(js|vue)$/)
    //         .enforce("post")
    //         .include.add("apollo-server")
    //         .add("src")
    //         .end()
    //         .use("istanbul-instrumenter-loader")
    //         .loader("istanbul-instrumenter-loader")
    //         .options({ esModules: true })
    //         .end();
    // },

    css: {
        // By default, only files that ends in *.module.[ext] are treated as CSS modules.
        // Setting this to true will allow you to drop .module in the filenames and treat all *.(css|scss|sass|less|styl(us)?) files as CSS modules.
        modules: true,

        // Whether to extract CSS in your components into a standalone CSS files (instead of inlined in JavaScript and injected dynamically).
        // extract: true in production, false in development

        // Whether to enable source maps for CSS. Setting this to true may affect build performance.
        sourceMap: false,

        // Pass options to CSS-related loaders.
        loaderOptions: {}
    },

    // devServer: {
    //     proxy: 'http://localhost:8081'
    // }

    // Whether to use thread-loader for Babel or TypeScript transpilation. This is enabled for production builds when the system has more than 1 CPU cores.
    parallel: require('os').cpus().length > 1,

    // pwa: Object

    // pluginOptions: {
    //     foo: {
    //         // plugins can access these options as
    //         // `options.pluginOptions.foo`.
    //     }
    // }
    
    // Added this line to create a new commit in master branch to test source code update in analyzer tool.
};
