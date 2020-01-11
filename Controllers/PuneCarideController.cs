using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PuneCarRideApi.Data;
using PuneCarRideApi.model;


namespace PuneCarRideApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PuneCarideController : ControllerBase
    {
       
        public IDataRepository _dataRepository { get; set; }

        public PuneCarideController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet("GetAllDestinations")]
        public async Task<IActionResult> GetAllDestinations()
        {
            var destinations = await _dataRepository.getAllDestination();
            return Ok(destinations);
        }

        [HttpGet("GetDestinationsDetails")]
        public async Task<IActionResult> GetDestinationsDetails(string route)
        {
            var destinationDetail = await _dataRepository.getDestinationDetails(route);
            return Ok(destinationDetail);
        }

        [HttpGet("GetPackage")]
        public async Task<IActionResult> GetPackage(string destination)
        {
            var vechile = await _dataRepository.getPackage(destination);
            return Ok(vechile);
        }

        [HttpPost("BookPackage")]
        public async Task<IActionResult> BookPackage([FromBody]Booking book)
        {
            _dataRepository.bookPackage(book);
            if (await _dataRepository.SaveAll())
                return Content("Success");

            throw new Exception("failed to save booking");
        }

    }
}