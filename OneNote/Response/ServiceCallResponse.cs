
namespace Common.Microsoft.Services.OneNote.Response
{
    class ServiceCallResponse
    {
        public Links links { get; set; }
    }

    class Links
    {
        public OneNoteUrl oneNoteClientUrl { get; set; }
        public OneNoteUrl oneNoteWebUrl { get; set; }
    }

    class OneNoteUrl
    {
        public string href { get; set; }
    }
}
