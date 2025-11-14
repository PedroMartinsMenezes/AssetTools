namespace AssetTool
{
    [JsonAsset("CascadeParticleSystemComponent")]
    public class UCascadeParticleSystemComponent : UParticleSystemComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}