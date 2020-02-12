using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;


namespace Steamworks
{
	internal class ISteamGameSearch : SteamInterface
	{
		public override IntPtr GetInterfacePointer() => GetApi.SteamGameSearch();
		
		
		internal ISteamGameSearch()
		{
			SetupInterface();
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_AddGameSearchParams")]
		private static extern GameSearchErrorCode_t _AddGameSearchParams( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKeyToFind, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchValuesToFind );
		
		#endregion
		internal GameSearchErrorCode_t AddGameSearchParams( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKeyToFind, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchValuesToFind )
		{
			var returnValue = _AddGameSearchParams( Self, pchKeyToFind, pchValuesToFind );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_SearchForGameWithLobby")]
		private static extern GameSearchErrorCode_t _SearchForGameWithLobby( IntPtr self, SteamId steamIDLobby, int nPlayerMin, int nPlayerMax );
		
		#endregion
		internal GameSearchErrorCode_t SearchForGameWithLobby( SteamId steamIDLobby, int nPlayerMin, int nPlayerMax )
		{
			var returnValue = _SearchForGameWithLobby( Self, steamIDLobby, nPlayerMin, nPlayerMax );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_SearchForGameSolo")]
		private static extern GameSearchErrorCode_t _SearchForGameSolo( IntPtr self, int nPlayerMin, int nPlayerMax );
		
		#endregion
		internal GameSearchErrorCode_t SearchForGameSolo( int nPlayerMin, int nPlayerMax )
		{
			var returnValue = _SearchForGameSolo( Self, nPlayerMin, nPlayerMax );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_AcceptGame")]
		private static extern GameSearchErrorCode_t _AcceptGame( IntPtr self );
		
		#endregion
		internal GameSearchErrorCode_t AcceptGame()
		{
			var returnValue = _AcceptGame( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_DeclineGame")]
		private static extern GameSearchErrorCode_t _DeclineGame( IntPtr self );
		
		#endregion
		internal GameSearchErrorCode_t DeclineGame()
		{
			var returnValue = _DeclineGame( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_RetrieveConnectionDetails")]
		private static extern GameSearchErrorCode_t _RetrieveConnectionDetails( IntPtr self, SteamId steamIDHost, IntPtr pchConnectionDetails, int cubConnectionDetails );
		
		#endregion
		internal GameSearchErrorCode_t RetrieveConnectionDetails( SteamId steamIDHost, out string pchConnectionDetails )
		{
			IntPtr mempchConnectionDetails = Helpers.TakeMemory();
			var returnValue = _RetrieveConnectionDetails( Self, steamIDHost, mempchConnectionDetails, (1024 * 32) );
			pchConnectionDetails = Helpers.MemoryToString( mempchConnectionDetails );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_EndGameSearch")]
		private static extern GameSearchErrorCode_t _EndGameSearch( IntPtr self );
		
		#endregion
		internal GameSearchErrorCode_t EndGameSearch()
		{
			var returnValue = _EndGameSearch( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_SetGameHostParams")]
		private static extern GameSearchErrorCode_t _SetGameHostParams( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKey, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchValue );
		
		#endregion
		internal GameSearchErrorCode_t SetGameHostParams( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKey, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchValue )
		{
			var returnValue = _SetGameHostParams( Self, pchKey, pchValue );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_SetConnectionDetails")]
		private static extern GameSearchErrorCode_t _SetConnectionDetails( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchConnectionDetails, int cubConnectionDetails );
		
		#endregion
		internal GameSearchErrorCode_t SetConnectionDetails( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchConnectionDetails, int cubConnectionDetails )
		{
			var returnValue = _SetConnectionDetails( Self, pchConnectionDetails, cubConnectionDetails );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_RequestPlayersForGame")]
		private static extern GameSearchErrorCode_t _RequestPlayersForGame( IntPtr self, int nPlayerMin, int nPlayerMax, int nMaxTeamSize );
		
		#endregion
		internal GameSearchErrorCode_t RequestPlayersForGame( int nPlayerMin, int nPlayerMax, int nMaxTeamSize )
		{
			var returnValue = _RequestPlayersForGame( Self, nPlayerMin, nPlayerMax, nMaxTeamSize );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_HostConfirmGameStart")]
		private static extern GameSearchErrorCode_t _HostConfirmGameStart( IntPtr self, ulong ullUniqueGameID );
		
		#endregion
		internal GameSearchErrorCode_t HostConfirmGameStart( ulong ullUniqueGameID )
		{
			var returnValue = _HostConfirmGameStart( Self, ullUniqueGameID );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_CancelRequestPlayersForGame")]
		private static extern GameSearchErrorCode_t _CancelRequestPlayersForGame( IntPtr self );
		
		#endregion
		internal GameSearchErrorCode_t CancelRequestPlayersForGame()
		{
			var returnValue = _CancelRequestPlayersForGame( Self );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_SubmitPlayerResult")]
		private static extern GameSearchErrorCode_t _SubmitPlayerResult( IntPtr self, ulong ullUniqueGameID, SteamId steamIDPlayer, PlayerResult_t EPlayerResult );
		
		#endregion
		internal GameSearchErrorCode_t SubmitPlayerResult( ulong ullUniqueGameID, SteamId steamIDPlayer, PlayerResult_t EPlayerResult )
		{
			var returnValue = _SubmitPlayerResult( Self, ullUniqueGameID, steamIDPlayer, EPlayerResult );
			return returnValue;
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamGameSearch_EndGame")]
		private static extern GameSearchErrorCode_t _EndGame( IntPtr self, ulong ullUniqueGameID );
		
		#endregion
		internal GameSearchErrorCode_t EndGame( ulong ullUniqueGameID )
		{
			var returnValue = _EndGame( Self, ullUniqueGameID );
			return returnValue;
		}
		
	}
}