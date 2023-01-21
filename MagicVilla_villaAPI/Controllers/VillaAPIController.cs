using AutoMapper;
using MagicVilla_villaAPI.Data;
using MagicVilla_villaAPI.Models;
using MagicVilla_villaAPI.Models.DTO;
using MagicVilla_villaAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace MagicVilla_villaAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;
        public VillaAPIController(IVillaRepository dbVilla, IMapper mapper)
        {
            _dbVilla = dbVilla;
            _mapper = mapper;
        }

        //<---- Get Method ---->
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VillaDTO>>> GetVillas()
        {
            IEnumerable<Villa> villalist = await _dbVilla.GetAllAsync();
            return Ok(_mapper.Map<List<VillaDTO>>(villalist));
        }

        [HttpGet("{id:int}", Name = "GetVilla")]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        //<---- Get Method id ---->
        public async Task<ActionResult<VillaDTO>> GetVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa =await _dbVilla.GetAsync(u => u.Id == id);

            if (villa == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<VillaDTO>(villa));
        }

        //<---- Post Method ---->

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<VillaDTO>> CreateVilla([FromBody] VillaCreateDTO createDTO)
        {

            if (await _dbVilla.GetAsync(u => u.Name.ToLower() == createDTO.Name.ToLower())!=null)
            {
                return BadRequest(ModelState);
            }

            if (createDTO == null)
            {
                return BadRequest(createDTO);
            }
            //if (villaDTO.Id > 0)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError);
            //}
            //villaDTO.Id = VillaStore.villaList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            //VillaStore.villaList.Add(villaDTO);

            Villa model = _mapper.Map<Villa>(createDTO);

            //Villa model = new()
            //{
            //    Name = createDTO.Name,
            //    Details = createDTO.Details,
            //    Rate = createDTO.Rate,
            //    Sqft = createDTO.Sqft,
            //    Ocupancy = createDTO.Ocupancy,
            //    ImgUrl = createDTO.ImgUrl,
            //    Amenity = createDTO.Amenity

            //};
            await _dbVilla.CreateAsync(model);

            return CreatedAtRoute("GetVilla", new { id = model.Id }, model);
        }

        //<---- Delete Method ---->

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "DeleteVilla")]

        public async Task<IActionResult> DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa =await _dbVilla.GetAsync(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            await _dbVilla.RemoveAsync(villa);
            return NoContent();
        }

        //<---- Put Method ---->
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id:int}", Name = "UpdateVilla")]
        public async Task<IActionResult> UpdateVilla(int id, [FromBody]VillaUpadateDTO upadateDTO)
        {
            if (upadateDTO == null || id != upadateDTO.Id)
            {
                return BadRequest();
            }
            // var villa = _db.Villas.FirstOrDefault(u => u.Id == id);

            Villa model = _mapper.Map<Villa>(upadateDTO);

            //Villa model = new()
            //{
            //    Id = upadateDTO.Id,
            //    Name = upadateDTO.Name,
            //    Details = upadateDTO.Details,
            //    Rate = upadateDTO.Rate,
            //    Sqft = upadateDTO.Sqft,
            //    Ocupancy = upadateDTO.Ocupancy,
            //    ImgUrl = upadateDTO.ImgUrl,
            //    Amenity = upadateDTO.Amenity

            //};
            await _dbVilla.UpdateAsync(model);
            return NoContent();
        }

        //<---- Patch Method ---->
        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpadateDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
                return BadRequest();
            }
            var villa =await _dbVilla.GetAsync(u => u.Id == id, tracked:false);

            VillaUpadateDTO villaDTO = _mapper.Map<VillaUpadateDTO>(villa);

            //VillaUpadateDTO villaDTO = new()
            //{
            //    Id = villa.Id,
            //    Name = villa.Name,
            //    Details = villa.Details,
            //    Rate = villa.Rate,
            //    Sqft = villa.Sqft,
            //    Ocupancy = villa.Ocupancy,
            //    ImgUrl = villa.ImgUrl,
            //    Amenity = villa.Amenity
            //};

            if (villa == null)
            {
                return BadRequest();
            }
            patchDTO.ApplyTo(villaDTO, ModelState);

            Villa model = _mapper.Map<Villa>(villaDTO);

            //Villa model = new Villa()
            //{
            //    Id = villaDTO.Id,
            //    Name = villaDTO.Name,
            //    Details = villaDTO.Details,
            //    Rate = villaDTO.Rate,
            //    Sqft = villaDTO.Sqft,
            //    Ocupancy = villaDTO.Ocupancy,
            //    ImgUrl = villaDTO.ImgUrl,
            //    Amenity = villaDTO.Amenity
            //};

            await _dbVilla.UpdateAsync(model);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }



    }
}
