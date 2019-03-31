using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using userDataManagement.Dtos;
using userDataManagement.Helpers;
using userDataManagement.IRepositories;
using userDataManagement.ModelsDb;

namespace userDataManagement.Controllers
{
    [Route("api/[controller]")]
    public class JobsController : Controller
    {
        private readonly IJobsRepository _jobsRepository;
        private readonly IMapper _mapper;

        public JobsController(IJobsRepository jobsRepository, IMapper mapper)
        {
            _jobsRepository = jobsRepository;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetJobs()
        {
            try
            {
                var jobs = _mapper.Map<List<JobDto>>(await _jobsRepository.GetJobs());
                return Ok(jobs);
            }
            catch (Exception ex)
            {
                return BadRequest("Bład przy dodawaniu nowego użytkownika" + ex.Message);
            }
        }

        [HttpPost()]
        [Route("add")]
        public async Task<IActionResult> AddUser([FromBody] JobDto job)
        {

            try
            {
                return Ok(await _jobsRepository.AddJob(_mapper.Map<JobDb>(job)));
            }
            catch (Exception ex)
            {
                return BadRequest("Bład przy dodawaniu nowego użytkownika" + ex.Message);
            }
        }

        [HttpGet("file")]
        public async Task<IActionResult> ReadFile()
        {
            var path = @"E:\projekty\user-data-management-core\UserDataManagement\Startup.cs";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            try
            {
                char[] buffer = new char[10];
                return Ok(file.ReadBlock(buffer, 0, buffer.Length));
            }
            catch (System.IO.IOException e)
            {
                return Ok("Error reading from " + path + "Message = " + e.Message);
            }

            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }

        [HttpGet("reference/{first}/{second}")]
        public async Task<IActionResult> Swap(int first, int second)
        {
            NumberManipulator n = new NumberManipulator();
            n.swap(ref first, ref second);
            return Ok(first.ToString() + " " + second.ToString());
        }

        [HttpGet("queue")]
        public async Task<IActionResult> Queue()
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");
            return Ok("Peek of Queue: " + numbers.Peek().ToString() + "--- Object removed from the begining: " + numbers.Dequeue());
        }

        [HttpGet("stack")]
        public async Task<IActionResult> Stack()
        {
            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");
            return Ok("Peek of Stack: " + numbers.Peek().ToString());
        }

        [HttpGet("sorted-list/{type}/{value}")]
        public async Task<IActionResult> SortedList(string type, int value)
        {
            SortedList<string, string> openWith =
          new SortedList<string, string>();
            
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            
            try
            {
                return Ok(openWith[type] + " " + openWith.Values[value] + " " + openWith.Keys[value]);
            }
            catch (Exception ex)
            {
                return BadRequest("Brak typu: " + type + " lub wartosci: " + value.ToString());
            }
        }

        [HttpGet("dictionary/{type}/{value}")]
        public async Task<IActionResult> Dictionary(string type, int value)
        {
            SortedList<string, string> openWith =
          new SortedList<string, string>();
            
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            
            try
            {
                return Ok(openWith[type] + " " + openWith.Values[value] + " " + openWith.Keys[value]);
            }
            catch (Exception ex)
            {
                return BadRequest("Brak typu: " + type + " lub wartosci: " + value.ToString());
            }
        }
    }
}