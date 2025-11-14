namespace AssetTool
{
    [JsonAsset("SoundNodeAttenuation")]
    public class USoundNodeAttenuation : USoundNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}