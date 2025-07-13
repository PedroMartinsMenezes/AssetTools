namespace AssetTool
{
    [JsonAsset("ActorPaletteSettings")]
    public class UActorPaletteSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}