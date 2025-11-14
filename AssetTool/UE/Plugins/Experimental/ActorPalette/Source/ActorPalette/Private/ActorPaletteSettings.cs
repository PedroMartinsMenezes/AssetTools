namespace AssetTool
{
    [JsonAsset("ActorPaletteSettings")]
    public class UActorPaletteSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}