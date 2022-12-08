using API_SystemSekolah.Repositories.Data;
using API_SystemSekolah.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_SystemSekolah.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateNilaiController : ControllerBase
    {
        private readonly UpdateNilaiRepository _repository;
        public UpdateNilaiController(UpdateNilaiRepository Repository)
        {
            _repository = Repository;
        }

        [HttpGet("{IdGuru}")]
        public ActionResult Get(int IdGuru)
        {
            try
            {
                var data = _repository.Get(IdGuru);
                if (data == null)
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Data Not Found",
                    });
                }
                else
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Data Load Successful",
                        Data = data
                    });
                }
            }
            catch
            {
                return BadRequest(new
                {
                    StatusCode = 400,
                    Message = "Something Wrong..."
                });
            }

        }
        [HttpGet("siswa/{id}/{id_guru}")]
        public ActionResult GetbySiswa(int id, int id_guru)
        {

            try
            {
                var data = _repository.GetbySiswa(id, id_guru);
                if (data == null)
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Data Tidak Berhasil Di-Update"
                    });
                }
                else
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Data  Berhasil Di-Update",
                        Data = data
                    });
                }
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    StatusCode = 400,
                    Message = e.Message
                });
            }

        }
    }
}
