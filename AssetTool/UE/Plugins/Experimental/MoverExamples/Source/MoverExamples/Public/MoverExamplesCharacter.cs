namespace AssetTool
{
    [JsonAsset("MoverExamplesCharacter")]
    public class AMoverExamplesCharacter : APawn
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}