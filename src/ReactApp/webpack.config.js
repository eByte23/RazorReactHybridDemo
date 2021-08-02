const path = require("path");
const webpack = require("webpack");

module.exports = {
  entry: "./src/index.tsx",

  module: {
    rules: [
      {
        test: /\.tsx?$/,
        use: ["ts-loader"],
        exclude: /node_modules/,
      },
    ],
  },
  resolve: {
    extensions: [".ts", ".js", ".tsx", ".jsx"],
  },
  output: {
    path: path.join(__dirname, "dist"),
    filename:
      process.env.NODE_ENV === "production" ? "ra.lib.min.js" : "ra.lib.js",
    libraryExport: "default",
    // This is the name of the object that will be exported
    // This will be accessibly as a global variable
    // when the script is include
    // e.g. 
    // <script src="ra.lib.js"></script>
    // <script>
    //   var ra = ra.lib;
    // </script>
    library: "ra",
  },
};
