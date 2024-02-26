namespace Infrastructure.Services;
using Domain.Models;

public class PostService
{
    List<Post> _post = new List<Post>();

    public List<Post> GetPosts()
    {
        return _post;
    }
    public void AddPost(Post post)
    {
        _post.Add(post);
    }
    public void UpdatePost(Post post)
    {
        foreach (var item in _post)
        {
            if(item.Id == post.Id)
            {
                item.Id=post.Id;
                item.Title=post.Title;
                item.Description=post.Description;
                item.VoteAmount=post.VoteAmount;
                item.CreatedAt=post.CreatedAt;
            }
        }
    }
    public void DeletePost(int id)
    {
        foreach (var item in _post)
        {
            if(item.Id==id)
            {
                _post.Remove(item);
                break;
            }
        }
    }
}