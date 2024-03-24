using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.ValidationRules.ArticleValidation
{
    public class CreateArticleValidation : AbstractValidator<Article>
    {
        public CreateArticleValidation()
        {
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Lütfen makale için bir kategori seçiniz!");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Makale başlığını boş geçemezsiniz!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Makale başlığı en az 5 karekterden oluşmalıdır!");
            RuleFor(x => x.Title).MaximumLength(100).WithMessage("Makale başlığı en fazla 100 karekterden oluşmalıdır!");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Makale açıklamasını boş geçemezsiniz!");
            
        }
    }
}
