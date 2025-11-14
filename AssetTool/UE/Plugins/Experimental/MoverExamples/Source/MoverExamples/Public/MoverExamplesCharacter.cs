namespace AssetTool
{
    [JsonAsset("MoverExamplesCharacter")]
    public class AMoverExamplesCharacter : APawn
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}