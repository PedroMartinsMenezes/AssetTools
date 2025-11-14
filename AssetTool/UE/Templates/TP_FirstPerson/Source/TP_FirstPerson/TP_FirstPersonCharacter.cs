namespace AssetTool
{
    [JsonAsset("TP_FirstPersonCharacter")]
    public class ATP_FirstPersonCharacter : ACharacter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}