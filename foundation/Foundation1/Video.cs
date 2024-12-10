public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public string DisplayVideoInfo(){
        return $"Title: {_title}\nAuthor: {_author}\nLength of the video: {_length} s.";
    }

    public void CommentList() {
        
    }

    public int NumberOfComments() {
        int totalComments = 0;
        foreach (Comment c in _comments) {
            totalComments ++;
        }      
        return totalComments;          
    }
}