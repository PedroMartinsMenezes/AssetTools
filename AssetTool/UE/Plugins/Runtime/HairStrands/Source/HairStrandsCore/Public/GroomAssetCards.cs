namespace AssetTool
{
    [JsonAsset("HairCardGenerationSettings")]
    public class UHairCardGenerationSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}