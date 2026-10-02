export async function searchUsers(search = '') {
    const response = await api.get(
      '/users/search',
      {
        params: {
          search,
        },
      }
    );
  
    return response.data;
  }