namespace AssetTool
{
    [JsonAsset("CascadeParticleSystemComponent")]
    public class UCascadeParticleSystemComponent : UParticleSystemComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}