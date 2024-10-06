namespace AssetTool
{
    [JsonAsset("NiagaraComponent")]
    public class UNiagaraComponent : UFXSystemComponent
    {
        [Location("void UNiagaraComponent::Serialize(FStructuredArchive::FRecord Record)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
