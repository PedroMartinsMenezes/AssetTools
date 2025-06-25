namespace AssetTool
{
    [JsonAsset("NiagaraSystem")]
    public class UNiagaraSystem : UFXSystemAsset
    {
        public List<UScriptStruct> NiagaraEmitterCompiledDataStruct = [];

        [Location("void UNiagaraSystem::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            if (transfer.Supports.ChangeEmitterCompiledDataToSharedRefs)
            {
                transfer.Move(ref NiagaraEmitterCompiledDataStruct, x => x.SerializeTaggedProperties(transfer));
            }

            return this;
        }
    }
}