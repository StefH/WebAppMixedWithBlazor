﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WebAppMixedWithBlazor.Models;

namespace WebAppMixedWithBlazor.Blazor.Components
{
    public partial class Section : ComponentBase
    {
        [Parameter]
        public SectionType SectionType { get; set; }

        [Parameter]
        public SectionModel Model { get; set; }

        [Parameter]
        public EventCallback<SectionModel> OnRemoveClick { get; set; }

        private void AddSection()
        {
            var newSection = new SectionModel
            {
                SectionType = SectionType.SubSection,
                Title = "section title...",
                Questions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Text = "place holder question 1..."
                    }
                }
            };

            Model.Sections.Add(newSection);
        }

        private void AddQuestion()
        {
            var newQuestion = new QuestionModel
            {
                Text = "please ask your question..."
            };

            Model.Questions.Add(newQuestion);
        }
    }
}