using Microsoft.AspNetCore.Mvc;
using projectApiCore.Interfaces;

namespace projectApiCore.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMessegesRepository _messegesRepository;

        [HttpGet("GetMessanges")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Object>))]
        public IActionResult GetMessanges(int worksId)
        {
            // var categories = _mapper.Map<List<CategoryDto>>(_categoryRepository.GetCategories());
            var historyMessages = _messegesRepository.GetMessages(worksId);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(historyMessages);
        }

        [HttpGet("SendMessanges")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Object>))]
        public IActionResult SendMessanges(int worksId, string msg)
        {
            // var categories = _mapper.Map<List<CategoryDto>>(_categoryRepository.GetCategories());
            _messegesRepository.SendMessage(msg, worksId);
           

            return Ok("send");
        }
    }
}
