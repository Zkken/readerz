﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Readerz.Application.Common.Models;
using Readerz.Application.Text.Queries.GetSupportedLanguages;
using Readerz.Application.Text.Queries.GetWordItems;
using Readerz.Application.Text.Queries.GetWordTranslation;

namespace Readerz.Web.Controllers
{
    [Authorize]
    public class TextController : BaseController
    {
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<TranslationResult>> TranslateWord(
            [FromQuery] string text, 
            [FromQuery] string to, 
            [FromQuery] string from
            )
        {
            return Ok(await Mediator.Send(new GetWordTranslationQuery
            {
                Text = text,
                To = to,
                From = from
            }));
        }

        [HttpGet]
        public async Task<ActionResult<LanguageVm>> GetSupportedLanguages()
        {
            return Ok(await Mediator.Send(new GetSupportedLanguagesQuery()));
        }

        [HttpGet]
        public async Task<ActionResult<WordsResult>> Process([FromQuery] string text)
        {
            return Ok(await Mediator.Send(new GetWordItemsQuery {Text = text}));
        }
    }
}