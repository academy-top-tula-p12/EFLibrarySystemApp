using EFLibrarySystemApp;

using (LibrarySystemContext context = new())
{
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();
}