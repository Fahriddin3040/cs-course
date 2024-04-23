namespace Server.Jwt
{
    public class JwtManager
    {
        public required string Secret { get; set; }
        public TimeOnly ExpireTime { get; set; }
    }
}