namespace AssetTool
{
    [JsonAsset("NiagaraSystem")]
    public class UNiagaraSystem : UFXSystemAsset
    {
        public Int32 EmitterCompiledDataNum;
        public List<UScriptStruct> NiagaraEmitterCompiledDataStruct = [];

        [Location("void UNiagaraSystem::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            if (Supports.ChangeEmitterCompiledDataToSharedRefs)
            {
                transfer.Move(ref EmitterCompiledDataNum);
            }

            NiagaraEmitterCompiledDataStruct.Resize(transfer, EmitterCompiledDataNum);

            NiagaraEmitterCompiledDataStruct.ForEach(x => x.SerializeTaggedProperties(transfer));

            return this;
        }
    }
}