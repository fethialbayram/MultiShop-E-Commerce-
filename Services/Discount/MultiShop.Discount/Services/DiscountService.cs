using Dapper;
using MultiShop.Discount.Context;
using MultiShop.Discount.Dtos;

namespace MultiShop.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _context;

        public DiscountService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateCouponAsync(CreateCouponDto createCouponDto)
        {
            string query = "insert into Coupons(Code,Rate,IsActive,ValdiDate) values (@code,@rate,@isActive,@validDate)";
            var parameters = new DynamicParameters();
            parameters.Add("@code",createCouponDto.CouponCode);
            parameters.Add("@rate",createCouponDto.Rate);
            parameters.Add("@isActive",createCouponDto.IsActive);
            parameters.Add("@validDate",createCouponDto.ValidDate);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteCouponAsync(int id)
        {
            string query = "delete from Coupons where Id=@couponId";
            var parameters = new DynamicParameters();
            parameters.Add("couponId",id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public Task<List<ResultCouponDto>> GetAllCouponsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCouponDto> GetByIdCouponAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCouponAsync(UpdateCouponDto updateCouponDto)
        {
            throw new NotImplementedException();
        }
    }
}
