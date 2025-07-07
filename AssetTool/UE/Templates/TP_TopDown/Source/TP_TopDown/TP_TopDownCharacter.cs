namespace AssetTool
{
    [JsonAsset("TP_TopDownCharacter")]
    public class ATP_TopDownCharacter : ACharacter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}