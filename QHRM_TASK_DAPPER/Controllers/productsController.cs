using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace QHRM_TASK_DAPPER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productsController : ControllerBase
    {
        private readonly IConfiguration _config;
        public productsController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public async Task<ActionResult<List<products>>> GetAllDetails()
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                IEnumerable<products> products = await selectAllProducts(connection);
                return Ok(products);
            }
        }

        [HttpGet("{productid}")]
        public async Task<ActionResult<products>> GetDetails(int productid)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                var product = await connection.QueryFirstAsync<products>("SELECT * FROM [products].[dbo].[products_details] WHERE id= @id", 
                    new{id = productid });
                return Ok(product);
            }
        }

        [HttpPost("add")]
        public async Task<ActionResult<List<products>>> AddProduct(products product)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                await connection.ExecuteAsync("INSERT INTO [products].[dbo].[products_details] ([product_name],[product_price]) VALUES(@product_name,@product_price);", 
                    new {product_name=product.product_name,product_price=product.product_price});
                return Ok();
            }
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<products>>> UpdateProduct(products product)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                await connection.ExecuteAsync("UPDATE [products].[dbo].[products_details] SET [product_name] = @product_name, [product_price] = @product_price WHERE id = @id",
                    new { id = product.id, product_name = product.product_name, product_price = product.product_price });
                return Ok();
            }
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<products>>> DeleteProduct(int productid)
        {
            using (var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                await connection.ExecuteAsync("DELETE FROM [products].[dbo].[products_details] WHERE id=@id", 
                    new { id = productid });
                return Ok();
            }
        }

        private static async Task<IEnumerable<products>> selectAllProducts(SqlConnection connection)
        {
            return await connection.QueryAsync<products>("SELECT * FROM [products].[dbo].[products_details]");
        }

    }
}
