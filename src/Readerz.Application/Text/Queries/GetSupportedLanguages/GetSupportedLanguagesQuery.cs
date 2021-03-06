﻿using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Readerz.Application.Common.Interfaces;
using Readerz.Application.Common.Models;

namespace Readerz.Application.Text.Queries.GetSupportedLanguages
{
    public class LanguageVm
    {
        public IEnumerable<Language> Languages { get; set; }
    }

    public class GetSupportedLanguagesQuery : IRequest<LanguageVm>
    {
    }
    
    public class GetSupportedLanguagesQueryHandler : IRequestHandler<GetSupportedLanguagesQuery, LanguageVm>
    {
        private readonly ITranslationService _translationService;

        public GetSupportedLanguagesQueryHandler(ITranslationService translationService)
        {
            _translationService = translationService;
        }

        public async Task<LanguageVm> Handle(GetSupportedLanguagesQuery request, CancellationToken cancellationToken)
        {
            return new LanguageVm
            {
                Languages = await Task.Run(() => _translationService.SupportedLanguages, cancellationToken)
            };
        }
    }
}
