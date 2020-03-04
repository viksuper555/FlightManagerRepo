﻿using FlightManager.Services.Contracts;
using FlightManager.Services.ServiceModels;
using FlightManager.ViewModels.Flight;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FlightManager.Controllers
{
    public class FlightController : Controller
    {
        private readonly IFlightService flightService;
        private readonly IReservationService reservationService;

        public FlightController(IFlightService flightService, IReservationService reservationService)
        {
            this.flightService = flightService;
            this.reservationService = reservationService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateFlightViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateFlightViewModel viewModel)
        {
             if (!ModelState.IsValid)
            {
                return Redirect("/Flight/Create");
            }
            if(viewModel.Arrival < viewModel.Departure)
            {
                return Redirect("/Flight/Create");
            }

            var flight = new FlightServiceModel
            {
                Origin = viewModel.Origin,
                Destination = viewModel.Destination,
                Departure = viewModel.Departure,
                Arrival = viewModel.Arrival,
                PlaneType = viewModel.PlaneType,
                PlaneNumber = viewModel.PlaneNumber,
                PilotName = viewModel.PilotName,
                PassengerSeatsLeft = viewModel.PassengerSeatsLeft,
                BusinessClassSeatsLeft = viewModel.BusinessClassSeatsLeft
            };

            flightService.Create(flight);

            return Redirect("/Home/Index");
        }

        public IActionResult IndexFlights(int page)
        {
            int flightsCount = flightService.GetCount();
            int flightsPerPage = 8;

            if (page < 1)
                return Redirect("/Home/Index");

            var endPage = (flightsCount / flightsPerPage) + 1;

            if (endPage > 1)
                endPage--;

            if (page > endPage)
                return Redirect("/Home/Index");

            var viewModel = new IndexFlightsViewModel
            {
                FlightsCount = flightsCount,
                Flights = new List<FlightViewModel>(),
                CurrentPage = page,
                EndPage = endPage

            };

            var flights = flightService.GetAllByPage(page);


            foreach (var flight in flights)
            {
                TimeSpan flightDuration = flight.Arrival.Subtract(flight.Departure);

                viewModel.Flights.Add(new FlightViewModel
                {
                    Id = flight.Id,
                    Origin = flight.Origin,
                    Destination = flight.Destination,
                    Departure = flight.Departure,
                    FlightDuration = flightDuration,
                    PassengerSeatsLeft = flight.PassengerSeatsLeft,
                    BusinessClassSeatsLeft = flight.BusinessClassSeatsLeft
                });
            }

            return View(viewModel);

        }
    
        public IActionResult IndexDetails(string id)
        {
            if(!flightService.Exists(id))
            {
                return Redirect("IndexFlights?page=1");
            }

            var flight = flightService.GetFlightById(id);
            var reservations = reservationService.GetAllReservationsByFlightId(id);

            var viewModel = new IndexDetailsViewModel()
            {
                Id = flight.Id,
                Origin = flight.Origin,
                Destination = flight.Destination,
                Departure = flight.Departure,
                Arrival = flight.Arrival,
                PlaneType = flight.PlaneType,
                PlaneNumber = flight.PlaneNumber,
                PilotName = flight.PilotName,
                PassengerSeatsLeft = flight.PassengerSeatsLeft,
                BusinessClassSeatsLeft = flight.BusinessClassSeatsLeft
            };

            foreach(var res in reservations)
            {
                viewModel.Reservations.Add(new ViewModels.Reservation.ReservationViewModel
                {
                    Id = res.Id,
                    FirstName = res.FirstName,
                    SecondName = res.SecondName,
                    LastName = res.LastName,
                    EGN = res.EGN,
                    PhoneNumber = res.PhoneNumber,
                    Nationality = res.Nationality,
                    TicketType = res.TicketType,
                    TicketsCount = res.TicketsCount,
                    Email = res.Email,
                    IsConfirmed = res.IsConfirmed
                });
            }
            return View(viewModel);
        }
    }
}