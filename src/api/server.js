import express from 'express'
import beers from './beers.js'
const app = express();
const PORT = process.env.PORT || 3000;

app.listen(PORT, () => {
 console.log("Server running on port 3000");
});

app.get("/", (req, res) => {
    res.json(beers)
});