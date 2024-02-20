const path = require("path");
const fs = require("fs");
const http = require("fs");

http.createServer(
    (req, res) => {
        if (req.url === "/") {
            fs.readFile(path.join(__dirname, "index.html")).then(
                (file) => {
                    res.writeHead(200,
                        {
                            "Consent-Type" : "text/html"
                        }
                    );
                    res.write(file);
                    res.end();
                }
            )
        } else if (req.url.match(".css")) {
            fs.readFile(path.join(__dirname, "styly.css")).then(
                (file) => {
                    res.writeHead(200,
                        {
                            "Consent-Type" : "text/css"
                        }
                    );
                    res.write(file);
                    res.end();
                }
            ).catch(
                (error) => {
                    console.log(error);
                    res.end();
                }
            )
        }
    }
)