using System;
using System.Collections.Generic;
using System.Text.Json;
using WebAppMixedWithBlazor.Models;
using Microsoft.AspNetCore.Components;

namespace WebAppMixedWithBlazor.Blazor.Components
{
    public partial class Form : ComponentBase
    {
        [Parameter]
        public FormModel MyForm { get; set; }

        public void AddSection()
        {
            var newSection = new SectionModel
            {
                SectionType = SectionType.Section,
                Title = "section title...",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Text = "placeholder question..."
                    }
                }
            };

            MyForm.Sections.Add(newSection);
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(MyForm, new JsonSerializerOptions {  WriteIndented = true });
            Console.WriteLine(json);
        }

        public void ItemDropped(QuestionModel q)
        {
            Console.WriteLine("QuestionDropped = '{0}'", q.Text);

            StateHasChanged();
        }

        public void SectionDropped(SectionModel s)
        {
            Console.WriteLine("SectionDropped = '{0}'", s.Title);

            StateHasChanged();
        }
    }
}