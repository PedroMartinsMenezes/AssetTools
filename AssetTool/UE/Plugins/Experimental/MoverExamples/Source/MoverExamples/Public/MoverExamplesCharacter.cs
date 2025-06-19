namespace AssetTool
{
    [JsonAsset("MoverExamplesCharacter")]
    public class AMoverExamplesCharacter : APawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}