"use strict";

const express = require("express");
const app = express();
const port = Number.parseInt(process.env.PORT || "8080", 10);

app.get("/", (_request, response) => {
  response.type("text").send("Your Express app is running.");
});

app.get("/health", (_request, response) => {
  response.status(200).json({ status: "ok" });
});

app.listen(port, "0.0.0.0");
