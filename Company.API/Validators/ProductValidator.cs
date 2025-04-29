using Company.API.DTOs;
using FluentValidation;

namespace Company.API.Validators
{
    public class ProductValidator:AbstractValidator<ProductDto>
    {
        public ProductValidator()
        {
            RuleFor(x=>x.ProductName)
                .NotEmpty().WithMessage("Ürün Adı Boş Bırakılamaz!")
                .Length(2, 50).WithMessage("Ürün Adı minimum 2 ve maksimum 50 karakter olmalıdır.");

            RuleFor(x => x.ImageUrl).NotEmpty()
                .WithMessage("Resim URL'si Boş Bırakılamaz!");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama Boş Bırakılamaz!")
                .Length(10, 200).WithMessage("Açıklama minimum 10 ve maksimum 200 karakter olmalıdır.");

            RuleFor(x => x.CategoryId)
                .NotEmpty().WithMessage("Kategori ID'si Boş Bırakılamaz!")
                .GreaterThan(0).WithMessage("Kategori ID'si 0'dan büyük olmalıdır.");
        }
    }
}
