const express = require('express');
const router = express.Router();

let flights = [
  { id: 1, from: 'NYC', to: 'LAX', date: '2023-10-01' },
  { id: 2, from: 'LAX', to: 'NYC', date: '2023-10-02' }
];

let bookings = [];
let bookingId = 1;

// GET /flights
router.get('/flights', (req, res) => {
  res.json(flights);
});

// POST /bookings
router.post('/bookings', (req, res) => {
  const newBooking = { id: bookingId++, ...req.body };
  bookings.push(newBooking);
  res.status(201).json(newBooking);
});

// GET /bookings/:id
router.get('/bookings/:id', (req, res) => {
  const booking = bookings.find(b => b.id === parseInt(req.params.id));
  if (!booking) return res.status(404).send('Booking not found');
  res.json(booking);
});

module.exports = router;