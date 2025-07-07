namespace AssetTool
{
    [JsonAsset("TP_ThirdPersonCharacter")]
    public class ATP_ThirdPersonCharacter : ACharacter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}