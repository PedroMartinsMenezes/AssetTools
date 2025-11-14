namespace AssetTool
{
    [JsonAsset("TP_ThirdPersonCharacter")]
    public class ATP_ThirdPersonCharacter : ACharacter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}