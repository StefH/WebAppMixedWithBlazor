using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebAppMixedWithBlazor.Models;

namespace WebAppMixedWithBlazor.Pages
{
    public class IndexModel : PageModel
    {
        public FormModel MyForm = new FormModel
        {
            Sections = new List<SectionModel>
            {
                new SectionModel
                {
                    Title ="first section",
                    Questions = new List<QuestionModel>
                    {
                        new QuestionModel
                        {
                            Text = "q 1"
                        },
                        new QuestionModel
                        {
                            Text = "q 2"
                        }
                    }
                },
                new SectionModel
                {
                    Title ="second section with nested",
                    Sections = new List<SectionModel>
                    {
                        new SectionModel
                        {
                            Title = "nested first",
                            Questions = new List<QuestionModel>
                            {
                                new QuestionModel
                                {
                                    Text = "test abc"
                                }
                            }
                        }
                    }
                }
            },
        };

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
