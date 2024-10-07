namespace AssetTool
{
    public class FColorVertexBuffer : FVertexBuffer, ITransferible
    {
        public FStripDataFlags StripFlags;

        [Location("void FColorVertexBuffer::Serialize( FArchive& Ar, bool bNeedsCPUAccess )")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref StripFlags);

            ///SerializeMetaData(Ar);
            ///
            ///if (Ar.IsLoading() && NumVertices > 0)
            ///{
            ///    // Allocate the vertex data storage type.
            ///    AllocateData(bNeedsCPUAccess);
            ///}
            ///
            ///if (!StripFlags.IsDataStrippedForServer() || Ar.IsCountingMemory())
            ///{
            ///    if (VertexData != NULL)
            ///    {
            ///        // Serialize the vertex data.
            ///        VertexData->Serialize(Ar);
            ///
            ///        if (VertexData->Num() > 0)
            ///        {
            ///            // Make a copy of the vertex data pointer.
            ///            Data = VertexData->GetDataPointer();
            ///        }
            ///    }
            ///}

            throw new NotImplementedException();
        }
    }
}
