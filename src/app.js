const express = require('express');
const bodyParser = require('body-parser');
const bookingsRoutes = require('./routes/bookings');

const app = express();
app.use(bodyParser.json());

app.use('/api', bookingsRoutes);

const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
  console.log(`Server is running on port ${PORT}`);
});