export type CommentPost = {
  title: string;
  content: string;
};

export type CommentGet = {
  title: string;
  content: string;
  createdBy: string;
  userFullName: string;
  userEmail: string;
  createdOn: any;
};
