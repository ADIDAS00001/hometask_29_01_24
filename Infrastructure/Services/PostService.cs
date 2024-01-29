using Domain.Models;

namespace Infrastructure.Services;

public class PostService
{
     List<Post> posts =new List<Post>();
    public List<Post> GetPosts()
    {
        return posts;
    }
    public void AddPosts(Post post)
    {
        posts.Add(post);
    }
    public void UpdatePosts(Post post)
    {
        foreach (var item in posts)
        {
            if(item.Id==post.Id)
            {
                item.Title=post.Title;
                item.Description=post.Description;
                item.Voteamount=post.Voteamount;
                item.Createdat=post.Createdat;
            }
            
        }
    }
    public void Delete(int id)
    {
        foreach (var item in posts)
        {
            if(id==item.Id)
            {
                posts.Remove(item);
            }
            
        }
    }
}
