using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class PostService
{
    private readonly CustomDbContext _context;

    public PostService(CustomDbContext context)
    {
        _context = context;
    }

    public async Task AddPostAsync(Post post)
    {
        _context.Posts.Add(post);
        await _context.SaveChangesAsync();
    }
}
