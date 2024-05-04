import { fetchBase } from "./httpService"

export const ProjectService = {
  getAll: async () => {
    const { data } = await fetchBase({
      metodo: "GET",
      recurso: "projects"
    })
    return data
  },
  createProject: async ({
    description,
    name,
    end_Time,
    project_Type
  }) => {
    const res = await fetchBase({
      metodo: "POST",
      recurso: "projects",
      body: {
        name,
        description,
        end_Time,
        project_Type
      }
    })
    return res
  }
}