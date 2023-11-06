using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentService.Pdf.Models
{
    [SwaggerSchema("DocumentDataForPdf")]
    public class DocumentData
    {
        public List<ContentMetaData> Placeholders { get; set; }
    }
}
