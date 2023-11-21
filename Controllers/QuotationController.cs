using CapitalChedidApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CapitalChedidApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotationController : ControllerBase
    {
        private readonly TestAppContext _dbContext;

        public QuotationController(TestAppContext ctx)
        {
            _dbContext = ctx;
        }

        [HttpGet]
        [Route("GetQuotations")]
        public List<Quotations> GetQuotations()
        {
            List<Quotations> quotations = _dbContext.Quotations.ToList();
            return quotations;
        }

        [HttpGet]
        [Route("GetQuotationsGridColumns")]
        public List<QuotationsGridColumns> GetQuotationsGridColumns()
        {
            List<QuotationsGridColumns> columns = _dbContext.QuotationsGridColumns.OrderBy(o => o.Sorting).ToList();
            return columns;
        }

        [HttpGet]
        [Route("GetQuotationStatuses")]
        public List<QuotationStatus> GetQuotationStatuses()
        {
            List<QuotationStatus> statuses = _dbContext.QuotationStatus.OrderBy(o => o.Sorting).ToList();
            return statuses;
        }
    }
}
