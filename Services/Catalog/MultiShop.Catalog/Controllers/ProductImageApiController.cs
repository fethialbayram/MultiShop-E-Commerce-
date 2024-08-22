﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Services.ProductImageServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageApiController : ControllerBase
    {
        private readonly IProductImageService _productImageService;

        public ProductImageApiController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet]

        public async Task<IActionResult> ListProductImage()
        {
            var values = await _productImageService.GetAllProductImagesAsync();
            return Ok(values); 
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdProductImage(string id)
        {
            var value = await _productImageService.GetByIdProductImageAsync(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImageDto)
        {
            await _productImageService.CreateProductImageAsync(createProductImageDto);
            return Ok("Ürün görseli başarıyla eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductImage(string id)
        {
            await _productImageService.DeleteProductImageAsync(id);
            return Ok("Ürün görseli başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
        {
            await _productImageService.UpdateProductImageAsync(updateProductImageDto);
            return Ok("Ürün görseli başarıyla güncellendi.");
        }
    }
}
