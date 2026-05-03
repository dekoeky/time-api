internal static class FavIconEndpoint
{
    extension(IEndpointRouteBuilder routes)
    {
        public void MapFavIcon()
        {
            var bytes = File.ReadAllBytes("wwwroot/favicon.ico");
            var result = Results.File(bytes, "image/vnd.microsoft.icon");

            routes.MapGet("favicon.ico", () => result);
        }
    }
}
