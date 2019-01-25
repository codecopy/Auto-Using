namespace AutoUsing.Proxy
{
    /// <summary>
    ///     The JSON serialized response returned to Visual Studio Code. 
    /// </summary>
    /// <typeparam name="T">
    ///     T is an object that inherits <see cref="Response{T}"/> which enables the
    ///     implicit operator to serialize it.
    /// </typeparam>

    public class Response{
        public bool Success { get; set; }
        public object Body { get; set; }
    }
}