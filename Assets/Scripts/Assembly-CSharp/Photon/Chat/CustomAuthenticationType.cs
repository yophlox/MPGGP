namespace Photon.Chat
{
	public enum CustomAuthenticationType : byte
	{
		Custom = 0,
		Steam = 1,
		Facebook = 2,
		Oculus = 3,
		PlayStation = 4,
		Xbox = 5,
		Viveport = 10,
		None = byte.MaxValue
	}
}
